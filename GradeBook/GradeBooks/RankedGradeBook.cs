namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override void GetLetterGrade(double averageGrade, char a)
        {
            if(averageGrade < 5)
            {
                throw new System.Exception();
            }
            else
            {
                return;
            }
        }
    }

}

