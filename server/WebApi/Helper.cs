public class Helper<T1, T2> where T1 : class where T2 : class
{
    public static ICollection<T1>? TransformList(ICollection<T2> t2Collection) {
        return t2Collection.Select(t2 => Activator.CreateInstance(typeof(T1), new object[] { t2 }) as T1)
        .ToList()!;
    }
}

// Ova klasa sluzi da pokaze jednu od lepota c#-a koju sam otkrio puno kasno, sadge


/*
    Pokazati ClanRepo overrideovane operatore za GetSameZnanje i 
*/