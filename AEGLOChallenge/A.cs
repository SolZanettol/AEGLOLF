﻿namespace n{public class A{public string a(string a,string b){int i=0;var d="";b=b.Replace(" ","");foreach(var c in a)(d,i)=i<b.Length&&(c==b.ToLower()[i]||c==b.ToUpper()[i])?(d+$"[{c}]",i+1):(d+c,i);return d.Replace("][","");}}}