public class Helper<T1, T2> where T1 : class where T2 : class
{
    public ICollection<T1>? TransformList(ICollection<T2> t2Collection) {
        return t2Collection.Select(t2 => Activator.CreateInstance(typeof(T1), new object[] { t2 }) as T1)
            .ToList()!;
    }
}

// Ova klasa sluzi da pokaze jednu od lepota c#-a koju sam otkrio puno kasno, sadge

/*
    Pokazati ClanRepo overrideovane operatore za GetSameZnanje i jos neku funkciju?
    Pokazati chain-ovane metode u AddProgram / cors u Program.cs
    Pokazati lambda metodu u GetSameZnanje
    Pokazati ICollection Guid-a u Vod/Tecaj/AkcijaRepo-u
    Vrv ima jos nesto zanimljivo al mi ne pada na pamet
*/

