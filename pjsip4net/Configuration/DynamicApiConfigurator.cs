using System;
using System.IO;
using System.Linq;
using System.Reflection;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;

namespace pjsip4net.Configuration
{
    public class DynamicApiConfigurator : IConfigureApi
    {
        private IConfigureApi _configurator;

        public void Configure(IContainer container)
        {
            var files = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).EnumerateFiles("*.dll");
            if (files.Where(file => !IsCoreAssembly(file)).Any(TryLoadConfigurator))
                _configurator.Configure(container);
        }

        private bool TryLoadConfigurator(FileInfo file)
        {
            try
            {
                var assembly = Assembly.LoadFrom(file.FullName);
                var apiConfiguratorType = assembly.GetTypes()
                    .FirstOrDefault(x => x.GetInterface(typeof (IConfigureApi).Name) != null);
                if (apiConfiguratorType != null)
                {
                    _configurator = Activator.CreateInstance(apiConfiguratorType).As<IConfigureApi>();
                    return true;
                }
            }
            catch (TypeLoadException)
            {
            }
            catch (ReflectionTypeLoadException)
            {
            }
            catch (BadImageFormatException)
            {
            }
            catch (FileNotFoundException)
            {
            }
            catch (FileLoadException)
            {
            }
            return false;
        }

        private bool IsCoreAssembly(FileInfo file)
        {
            return file.Name.Contains("pjsip4net.dll") || file.Name.Contains("pjsip4net.Core");
        }
    }
}