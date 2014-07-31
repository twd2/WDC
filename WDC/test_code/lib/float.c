int itof(int a_addr, int data)
{
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri"); //load a_addr
    asm("pushi ebp");
    asm("pushi -3");
    asm("addi");
    asm("ldri"); //load data
    asm("itof"); //cast to float
    asm("strf"); //set a as float
}

int ff(int a_addr, int data1, int data2) uses(int tmp)
{
    itof(a_addr, data1);
    itof(&tmp, data2);
    fdiv(a_addr, a_addr, &tmp);
}

int ftoi(int a_addr)
{
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri"); //load a_addr
    asm("ldrf"); //load a as float
    asm("ftoi"); //cast to int
    asm("popi eax"); //return
}

int fadd(int c_addr, int a_addr, int b_addr)
{
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri"); //load c_addr
    asm("pushi ebp");
    asm("pushi -3");
    asm("addi");
    asm("ldri"); //load a_addr
    asm("ldrf"); //load a as float
    asm("pushi ebp");
    asm("pushi -4");
    asm("addi");
    asm("ldri"); //load b_addr
    asm("ldrf"); //load b as float
    asm("addf");
    asm("strf"); //set c as float
}

int fsub(int c_addr, int a_addr, int b_addr)
{
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri"); //load c_addr
    asm("pushi ebp");
    asm("pushi -3");
    asm("addi");
    asm("ldri"); //load a_addr
    asm("ldrf"); //load a as float
    asm("pushi ebp");
    asm("pushi -4");
    asm("addi");
    asm("ldri"); //load b_addr
    asm("ldrf"); //load b as float
    asm("subf");
    asm("strf"); //set c as float
}

int fmul(int c_addr, int a_addr, int b_addr)
{
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri"); //load c_addr
    asm("pushi ebp");
    asm("pushi -3");
    asm("addi");
    asm("ldri"); //load a_addr
    asm("ldrf"); //load a as float
    asm("pushi ebp");
    asm("pushi -4");
    asm("addi");
    asm("ldri"); //load b_addr
    asm("ldrf"); //load b as float
    asm("mulf");
    asm("strf"); //set c as float
}

int fdiv(int c_addr, int a_addr, int b_addr)
{
    asm("pushi ebp");
    asm("pushi -2");
    asm("addi");
    asm("ldri"); //load c_addr
    asm("pushi ebp");
    asm("pushi -3");
    asm("addi");
    asm("ldri"); //load a_addr
    asm("ldrf"); //load a as float
    asm("pushi ebp");
    asm("pushi -4");
    asm("addi");
    asm("ldri"); //load b_addr
    asm("ldrf"); //load b as float
    asm("divf");
    asm("strf"); //set c as float
}

int printf(int a_addr)
{
    
}