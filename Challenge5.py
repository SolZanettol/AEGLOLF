def f(a,b):
    r=a+": "+str(len(a))+", "+b+": "+str(len(b))+"\n   "
    for i in b:
        r+=" "+i
    m=[[0]]
    for i in range(len(b)):
        m[0]+=[i+1]
    for i in range(len(a)):
        m+=[[i+1]]
    for i in range(len(a)):
        for j in range(len(b)):
            if a[i]==b[j]:
                m[i+1]+=[m[i][j]]
            else:
                m[i+1]+=[min(m[i][j],m[i+1][j],m[i][j+1])+1]
    for i in range(len(a)+1):
        r+="\n"
        if i!=0:
            r+=a[i-1]
        else:
            r+=" "
        for j in m[i]:
            r+=" "+str(j)
    r+="\n"+str(m[-1][-1])
    return r
