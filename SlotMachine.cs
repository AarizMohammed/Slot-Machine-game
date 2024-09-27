using System;
namespace SlotMachine
{
	public class SlotMachine
	{
		private List<string> _images;
		public int Balance { get; private set; }
		public static bool IsEasy { get; set; }

		public SlotMachine()
		{
			_images = new List<string>
			{
				"apple.png",
                "casino.png",
				"cherry.png",
				"gambler.png",
				"lemon.png",
				"watermelon.png",

            };
			Balance = 100;
			
		}
		public List<string> Spin(int numberOfImages)
		{
			var result = new List<string>();

			int max = IsEasy ? 3 : _images.Count;

			for (int i = 0; i <numberOfImages; i++)
			{
				int randomIndex = new Random().Next(0, max);
				result.Add(_images[randomIndex]);
			}

			//todo: update the balance
			if (result[0] == result[1] && result[1] == result[2])
			{
				if (result[0] == "casino.png")
					Balance += 500;
				else
					Balance += 100;

				Balance += result[0] == "casino.png" ? 500 : 100;
			}
			else
			{
				Balance -= 10;
			}

			return result;

		}
	}
}

