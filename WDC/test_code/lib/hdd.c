int writebyte(int addr, int data)
{
    asm("pushi 2");
    asm("popi ah"); //ah=2
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri");
    asm("popi ecx"); //ecx=addr
    data=data && 255; 
    asm("pushi ebp");
    asm("pushi -3");
    asm("addi");
    asm("ldri");
    asm("popi al"); //al=data
    asm("int 13");
}
int readbyte(int addr)
{
    asm("pushi 1");
    asm("popi ah"); //ah=1
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri");
    asm("popi ecx"); //ecx=addr
    asm("int 13");
    asm("pushi al"); 
    asm("popi eax"); //eax=al
}
