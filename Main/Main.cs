using Animation;

namespace Main;

class MainProgram
{
	static void Main(string[] args)
	{
		Console.WriteLine("Main:: State: Init   OutMessage: MainInit");
		AnimationProgram.Init();

		Console.ReadLine();
	}
}