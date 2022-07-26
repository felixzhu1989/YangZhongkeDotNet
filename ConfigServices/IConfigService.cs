using System;

namespace ConfigServices
{
    public interface IConfigService
    {
        string GetValue(string name);
    }
}
