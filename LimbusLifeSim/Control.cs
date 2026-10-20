/// <summary>
///
/// </summary>
class Control
{
//Start user at age 0
//As time progresses, increases age of user.
//Chance encounters happen randomly each "year"
//Drain/Gain stats each year
//->Health goes up in early years, down in later years
//->Wealth goes down before employment, up/down after
//->Sanity goes down each year (city life moment)
    static void Main(string[] args)
    {
        /*
		Set up user
		Loop until user's dead
			Check if events happen (higher chance as you age)
			Chance encounters
		Display traits/feats and stats
		*/
		EventHandler eventHandler = new EventHandler();
    }
}