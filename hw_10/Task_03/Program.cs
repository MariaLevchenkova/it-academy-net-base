using HW_03;

var junior = new JuniorDeveloper("Ivan", "Ivanov", "Github", 0, new List<string>
{
    "C#",
    ".Net",
    "VS 2022",
    "Git",
    "HTML",
    "CSS",
    "JavaScript"
});

var middle = new MiddleDeveloper("Peter", "Petrov", "Github", 2, new List<string>
{
    "C#",
    ".Net",
    "VS 2022",
    "PHP",
    "Pyton",
     "Git"
});

var senior = new SeniorDeveloper("Vacili", "Klimov", "Github", 4, new List<string>
{
    "C++",
    "C#",
    ".Net",
    " VS 2022",
    " CSS",
    "JavaScript",
    "HTML",
     "Git",
     "Rider"
    });

var teamLeader = new TeamLeader("Ekaterina", " Valishko", "Github", 6, new List<string>
{
    "C#",
    ".Net",
    " VS 2022",
    " CSS",
    "JavaScript",
    "HTML",
    "Git",
    "Rider"
});

var architect = new Architect("Victoria", " Plotnik", "Github", 10, new List<string>
{
    "C#",
    ".Net",
    "C++",
    " VS 2022",
    " CSS",
    "JavaScript",
    "HTML",
    "Git",
    "PHP",
    "Pyton",
    "Rider"
    });
var company = new Company();
company.Add(junior);
company.Add(middle);
company.Add(senior);
company.Add(teamLeader);
company.Add(architect);

company.ShowEmployees();

