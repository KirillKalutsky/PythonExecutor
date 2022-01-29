using System.Collections.Generic;

namespace Parser.Infrastructure.Python
{
    public class ScriptResponse
    {
        public List<string> Names { get; set; }
        public List<AddrPart> Addresses { get; set; }
    }
}
