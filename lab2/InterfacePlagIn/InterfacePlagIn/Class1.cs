using System;
namespace InterfacePlagIn
{
    public interface IAppFunctionality
    {
        void IncludeIt();
        void OpenFile(string fileName);
    }
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class PlagInInfoAttribute : System.Attribute
    {
        public string PlagInName { get; set; }
        public string FileFormat { get; set; }
    }
}