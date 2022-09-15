
using RPA.Genie.Activities;

namespace RPA.Genie.NugetTemplate
{
    public class Calculator : Activity
    {
        public InProperty<int> FirstInteger { get; set; }
        public InProperty<int> SecondInteger { get; set; }
        public OutProperty<int> Total { get; set; }

        public override ExecutionResult Execute(IActivityContext activityContext)
        {
            var firstInt = FirstInteger.GetValue(activityContext);  //Get Value from UI
            var secondInt = SecondInteger.GetValue(activityContext);
            int total = firstInt + secondInt;
            activityContext.SetPropertyValue(Total, total);  //Set value to UI
            return ExecutionResult.Empty;
        }

    }
}