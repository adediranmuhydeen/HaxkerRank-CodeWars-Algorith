using System.ComponentModel;

namespace Algorithm
{
    public enum TestEnum
    {
        [Description("Best Day")]
        BestDay = 1,
        [Description("Good Day")]
        GoodDay,
        [Description("Every Day")]
        EveryDay,
        [Description("Right Day")]
        RightDay
    }
}
