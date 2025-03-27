string product = Console.ReadLine();


switch (product)
{
	case "banana":
	case "cherry":
	case "apple":
	case "kiwi":
	case "lemon":
	case "grapes":
		Console.WriteLine("fruit");
		break;

	case "tomato":
	case "cucumber":
	case "pepper":
	case "carrot":
		Console.WriteLine("vegetable");
		break;

	default:
		Console.WriteLine("unknown");
		break;
}