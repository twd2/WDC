int println()
{
    putchar("\r");
    putchar("\n");
}
int printi(int num, int canzero) uses(int div, int a)
{
    if (num==0) 
    {
        putchar("0");
        return 0;
    }
    if (num<0) 
    {
        num=0-num;
        putchar("-");
    }
    div=1000000000;
    //canzero=0;
    while (div>=1)
    {
        a=num/div % 10;
        if (a != 0)
        {
            putchar(a+"0");
            canzero=1;
        }
        else if(canzero)
        {
                putchar(a+"0");
        }
        div=div/10;
    }
}
int readi() uses(int a, int b)
{
    b=0;
    a=getchar(1);
    while (a==10 || a==13 || a==" ") a=getchar(1); //skip \r \n " "
    while (a!=10 && a!=13 && a!=" ")
    {
        b=b*10+a-"0";
        a=getchar(1);
    }
    return b;
}
int putchar(int ch)
{
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri");
    asm("popi eax"); //eax=ch
    asm("int 5");  //�ж�5: ��ʾ������eax���ַ�
}
int getchar(int echo)
{
    asm("int 9"); //�ж�9: ��ȡ�ַ�, ������eax, ��������ֵҲ��eax
    if(echo) asm("int 5");
}
int printstr(int args) uses(int i)
{
    i=0;
    while(args[i] != 0)
    {
        putchar(args[i]);
        ++i;
    }
}