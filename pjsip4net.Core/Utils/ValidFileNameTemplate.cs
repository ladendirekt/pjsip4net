namespace pjsip4net.Core.Utils
{
    public static class ValidFileNameTemplate
    {
        public static bool Check(string fileName)
        {
            Helper.GuardNotNullStr(fileName);
            Helper.GuardIsTrue(fileName.EndsWith(".wav"));
            return true;
        }
    }
}
