namespace Quest
{
    public class Player
    {
        public string Name { get; }
        public int Awesomness { get; set; }

        public Player(string name)
        {
            Name = name;
            Awesomness = 50;
        }

        public string GetPlayerStatus()
        {
            string status = "okay";
            if (Awesomness >= 75)
            {
                status = "great";
            }
            else if (Awesomness < 25 && Awesomness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomness < 10 && Awesomness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Player, {Name}, is {status}";
        }
    }
}