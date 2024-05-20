using Common.Domain.Interfaces.CriteriaPattern;
using CriteriaPatternExample;

var list = new List<Test>()
{
    new Test() { 
        Color = "white",
        Type = 1,
        Width = 100
    },
    new Test() {
        Color = "red",
        Type = 1,
        Width = 50
    },
    new Test() {
        Color = "red",
        Type = 3,
        Width = 200
    },
    new Test() {
        Color = "blue",
        Type = 2,
        Width = 500
    }
};

ICriteria<Test> Red = new CriteriaRed();
ICriteria<Test> White = new CriteriaWhite();
ICriteria<Test> Type1 = new CriteriaType1();

var whiteAndRed = Red.And(White);
var filter = whiteAndRed.MeetCriteria(list);
var redAndType1 = Red.And(Type1);
filter = redAndType1.MeetCriteria(list);
Console.WriteLine(filter.Count);
