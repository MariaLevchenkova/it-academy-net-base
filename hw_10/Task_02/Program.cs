using Task_02;

List<Item> collection = new List<Item>
{
    new Application("name", "code", "category", 1000),
    new Film( "One", "code", "category", 2300, " B.B. Bernardi "," Mr A. Fread",""),
    new Music( "Ferst", "code", "category", 1500, "singer",400)
};

foreach (var item in collection)
{
    item.Play();
}