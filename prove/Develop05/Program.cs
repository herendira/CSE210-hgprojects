using System;

class Program
{
    static void Main(string[] args)
    {
        int totalPoints = 0;
        List<Goal> goals = new List<Goal>();

        bool run = true;
        while (run)
        {
            Console.WriteLine("\n                                    ETERNAL QUEST");
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("\nMenu Options:\n1. Create new Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n Select a choice from the menu: ");
            string option = Console.ReadLine();
            switch (option)


            {
                case "1":
                    //Goal g;
                    Simple s = new Simple();
                    Console.Clear();
                    Console.WriteLine("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n Which type of Goal would you like to create? ");
                    string creop = Console.ReadLine();
                    switch (creop)
                    {
                        case "1":
                            
                            Simple si = new Simple();

                            Console.WriteLine("What is the name of your Goal");
                            si.SetName(Console.ReadLine());
                            Console.WriteLine("What is a short description of your Goal");
                            si.SetDescription(Console.ReadLine());
                            Console.WriteLine("What is the amount of points associated with this Goal");
                            si.SetPoints(int.Parse(Console.ReadLine()));
                            
                            goals.Add(si);


                            break;

                        case "2":
                            
                            Eternal et = new Eternal();

                            Console.WriteLine("What is the name of your Goal");
                            et.SetName(Console.ReadLine());
                            Console.WriteLine("What is a short description of your Goal");
                            et.SetDescription(Console.ReadLine());
                            Console.WriteLine("What is the amount of points associated with this Goal");
                            et.SetPoints(int.Parse(Console.ReadLine()));
                            goals.Add(et);
                            break;

                        case "3":
                           

                            Checklist c = new Checklist();

                            Console.WriteLine("What is the name of your Goal");
                            c.SetName(Console.ReadLine());
                            Console.WriteLine("What is a short description of your Goal");
                            c.SetDescription(Console.ReadLine());
                            Console.WriteLine("What is the amount of points associated with this Goal");
                            c.SetPoints(int.Parse(Console.ReadLine()));
                            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                            c.SetEventPoints(int.Parse(Console.ReadLine()));
                            Console.WriteLine("What is the bonus for accomplishing it that may times?");
                            c.SetManyTimes(int.Parse(Console.ReadLine()));
                            goals.Add(c);

                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                    break;

                case "2": // lists all the goals

                    {
                        foreach (var goal in goals)
                        {
                            Console.WriteLine(goal.GetDisplayMessage());
                        }

                        break;

                    }



                case "3": // save to file
                    {
                        Console.WriteLine("Enter the filename for saving the goals:");
                        string filename = Console.ReadLine();

                        var lines = new List<string>();
                        lines.Add($"{totalPoints},{goals.Count()}");
                        foreach (var i in goals)
                        {
                            lines.Add(i.Serialize());
                        }
                        File.WriteAllLines(filename, lines);
                    }

                    break;

                case "4": // load from file
                    {
                        Console.WriteLine("Enter the filename for saving the goals:");
                        string filename = Console.ReadLine();
                        var lines = File.ReadAllLines(filename);
                        goals.Clear();
                        var header = lines[0].Split(",");
                        totalPoints = int.Parse(header[0]);
                        var totalGoals = int.Parse(header[1]);
                        for (var i = 0; i < totalGoals; i++)
                        {
                            var goal = Deserialize(lines[i + 1]);
                            goals.Add(goal);
                        }
                    }
                    break;

                case "5": // record event
                    {
                        Console.WriteLine("What goal do you want to complete?");
                        int selectedIndex = int.Parse(Console.ReadLine());
                        var goal = goals[selectedIndex - 1];
                        totalPoints += goal.RecordEvent();
                        break;
                    }



                case "6":
                    Console.WriteLine("Your progession is important...thanks for trusting  us");
                    run = false;

                    break;

                default:
                    Console.WriteLine("Option no valid, read the menu ");
                    continue;
            }


        }

    }

    private static Goal Deserialize(string line)
    {
        var tokens = line.Split(',');
        switch (tokens[0])
        {
            case "Simple":
                {
                    var goal = new Simple(tokens[1], tokens[2], int.Parse(tokens[3]), bool.Parse(tokens[4]));
                    return goal;
                }
            case "Eternal":
                {
                    var goal = new Eternal(tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), bool.Parse(tokens[5]));
                    return goal;
                }
            case "Checklist":
                {
                    var goal = new Checklist(tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), bool.Parse(tokens[6]), int.Parse(tokens[7]));
                    return goal;
                }

            default:
                throw new Exception("goal type not supported");
        }
    }


    





}

