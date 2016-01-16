pjsip4net
=========
A [pjsip](http://www.pjsip.org/) high-level user agent API wrapper for .Net. 

License
-----------
Copyright pjsip4net Boris Tveritnev.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use these files except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

Pjsip version supported
-----------
Currently only old 1.x branch version is supported. The code is distributed with custom built pjsip 1.4 dll file. No other versions were tested, however one can develop his own interop code version and plug it into the application. If you do, please, send me a pull request.

Roadmap
-----------
Things to come in order of importance:
  * pjsip 1.latest support
  * pjsip 2.x line support

Installation
-----------
To install pjsip4net via NuGet package manager execute a following command in the Package Manager Console: 
```
Install-Package pjsip4net
```
pjsip4net carries several native libraries that can not be automatically referenced from your managed projects. The package includes .targets file that copies these native libraries to the build output folder. That means, that if you would like these libraries to be copied to several project build folders (say, an integration test project), then you would need to include this package in every of those projects.  
Note: you may get a following warning after you included pjsip4net NuGet package:
```
Warning	103	There was a mismatch between the processor architecture of the project being built "MSIL" and the processor architecture of the reference "pjsip4net.Core, Version=0.2.0.20, Culture=neutral, processorArchitecture=x86", "x86". This mismatch may cause runtime failures. Please consider changing the targeted processor architecture of your project through the Configuration Manager so as to align the processor architectures between your project and references, or take a dependency on references with a processor architecture that matches the targeted processor architecture of your project.	ConsoleApplication1
```
The message is pretty self-explanatory. Make sure to change your project target to x86, otherwise you will get runtime failure running your app on x64 platform.  
Thanks to @amccool for making a first version of this package and pushing me to complete the work.  

Configuration
-----------
There are a number of things one should configure in order to tune pjsip within particular environment. These things include:
  * Signaling transport - you can choose which transport to send SIP packets over (UDP, TCP or TLS), to which port to bind to;
  * Media - enable or disable SRTP, specify capture and playback devices, enable or disable VAD;
  * Network settings - enable or disable NAT traversal protocols, specify proxies, DNS servers;
  * Accounts - specify accounts you want your user agent to register automatically upon startup. You can always register accounts dynamically with your application code;
  * User agent settings - enable or disable auto answer, or auto conference, specify maximum number of simultaneous calls allowed.

There are several ways to configure library:
  * app.cfg file. Library comes with built-in support for configuration provided in standard .Net configuration files. You have to tell pjsip4net to use this source of configuration at startup (https://gist.github.com/siniypin/7860029);
  * custom config source, by implementing `IConfigurationProvider`. To plug it in, you have to tell the library to use it at startup phase (https://gist.github.com/siniypin/5951687). In fact the previous option is an implementation of this interface by `CfgFileConfigurationProvider`;
  * configure programmatically, by supplying blocks of code that configure options at runtime (https://gist.github.com/siniypin/7860386);

Interop assembly automatic discovery
-----------
The library tries to be pjsip version agnostic. At start-up phase it will scan through your application folder and will try to load an assembly that provides bindings to pjsip.dll. This feature is particularly useful to application developers who want to switch underlying pjsip library without changes to their application code. This behavior is enabled by default, so nothing has to be done.
If you find yourself comfortable with well tested and proven to work correctly in your scenarios version of pjsip.dll you can bind it into your application at compile time phase by referencing an interop assembly from your application (https://gist.github.com/siniypin/7860351) . 

Dependency injection
-----------
pjsip4net leverages the dependency injection principle by means of pluggable DI-containers. It uses them to loosely couple the code and to enable automatic resolution of library's public contracts within applications that already use DI-containers. 
If no container is provided, the library will use its own simple container internally. Currently the only external container supported out of the box is Castle Windsor (http://docs.castleproject.org/Windsor.MainPage.ashx). 
To plug your own container instance into library you have to tell it to use it startup phase (https://gist.github.com/siniypin/7860556)

Logging
-----------
pjsip4net doesn't impose any restrictions upon logging framework, well, almost. To be precise it leverages the Apache Commons Logging facade (http://netcommon.sourceforge.net/) to hide a specific framework utilized by application, thus there is a restriction on frameworks supported by Common.Logging. Currently supported libraries are:
  * log4net (1.2.11, 1.2.10 and 1.2.9);
  * NLog (1.0, 2.0);
  * Enterprise Library logging (3.1, 4.1, and 5.0);

It is an application developers' responsibility to configure their favorite logging framework and to plug Common.Logging in (https://gist.github.com/siniypin/7860265).

Examples
-----------
The library comes with console application one can use to test if configuration options specified are correct within particular environment or to study application code. Almost every scenario is covered within this small application: registering accounts, issuing calls, sending instant messages, adding buddies, specifying codecs and media devices. 
In order to build a library you have to run build.bat file first. pjsip4net uses UpperCut project to run builds. If you want to know more about how it works, please refer to UpperCut documentation (http://uppercut.pbworks.com/w/page/9022442/FrontPage).  
One can also find numerous examples here: https://gist.github.com/siniypin

Debugging
-----------
Running the test console within the managed debugger you may encounter an "vshost stopped working" error in certain scenarios. To avoid this problem please run test console application by running executable file your compiler generates and attach a debugger later (VS menu: Tools -> Attach to process...).
