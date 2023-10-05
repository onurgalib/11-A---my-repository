namespace StaticConstructorsDestructorsStackAndHeap
{
    public static class VetClinic
    {
        public static string Name { get; set; }

        static VetClinic()
        {
            Name = "Super klinika Shumen";
            Console.WriteLine("Vnimanie: Pusna se statichen konstruktor.");
        }
    }
}