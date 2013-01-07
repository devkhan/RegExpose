using System.Collections.Generic;
using RegExpose.Nodes.Parens;

namespace RegExpose
{
    public interface IRegexEngine
    {
        State State { get; set; }
        string Input { get; }
        void AddCapture(int number, int index, string value);
        bool PopCapture(int number);
        IEnumerable<ParenCapture> GetCaptures(int number);
        void AddSavedState(ISavedState state);
    }
}