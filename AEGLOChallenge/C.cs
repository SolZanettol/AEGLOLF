using System.Linq;namespace n{public class C{public int[][]c(int[][]a){foreach(var c in a)System.Array.Sort(c);return a.OrderBy(c=>c.Sum()).ToArray(); }}}
