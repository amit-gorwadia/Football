using System.ComponentModel;

namespace Football.Data
{
    public enum Score
    {
       [Description("Draw")]
       D,
       [Description("Win")]
       W,
       [Description("Lost")]
       L
    }
}
