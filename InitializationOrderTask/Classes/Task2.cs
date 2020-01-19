namespace InitializationOrderTask.Classes
{
    public class Task2
    {
        public Task2()
        {
            InstanceCounter++;
        }

        public static int InstanceCounter { get; private set; }

        public string CounterOfObjectsView()
        {
            return "There are " + InstanceCounter + " objects of class \"Task2\"";
        }
    }
}
