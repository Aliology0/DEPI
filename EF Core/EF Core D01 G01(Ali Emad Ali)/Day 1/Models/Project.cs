
namespace Day_1.Models
{
    public class Project
    {

        #region Attributes
        private int id;
        private string name = "OurProject";
        private decimal cost;
        #endregion

        #region Properties
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Cost
        {
            get => cost;
            set => cost = value;
        }
        #endregion

        #region Constructors
        public Project(string _name, decimal _cost)
        {
            name = _name;
            cost = _cost;
        }

        public Project() : this("OurProject", 500000.00m)
        {
        }
        #endregion
    }
}