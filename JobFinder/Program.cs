using JobFinder.Abstract;
using JobFinder.Entities;
using JobFinder.Services;

Console.WriteLine("JOB FINDER");

//ID-CreatedOn-FirstName-LastName-PhoneNumber 
//csv comma seperated values

ICsvConvertable freelancerInstance = new Freelancer()
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTimeOffset.Now,
    FirstName = "Elif",
    LastName = "*",
    WorkExperience = "5 years",
    Review = new List<Review>
    {
        new Review {Text = "Excellent Freelancer", Rating = 5},
        new Review {Text = "Great work!", Rating = 4},
    }

};

var customerInstance = new Customer()
{
    Id = Guid.NewGuid(),
    FirstName = "Selim",
    LastName = "*",
    PhoneNumber = "0550",

};

Console.WriteLine(freelancerInstance.GetType().ToString().Split(".").LastOrDefault()); //We are gonna reach the type of this instance (customer or freelancer)

NotepadService notepadService = new();

notepadService.SaveToNotepad(freelancerInstance); 
notepadService.SaveToNotepad(customerInstance);


Console.WriteLine(notepadService.GetOnNotepad("E:\\Programming\\YetGen .NET\\JobFinder\\JobFinder\\Database\\Customer.txt"));
Console.WriteLine(notepadService.GetOnNotepad("E:\\Programming\\YetGen .NET\\JobFinder\\JobFinder\\Database\\Freelancer.txt"));
Console.WriteLine();



