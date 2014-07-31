//#inc test1
#inc io
#inc int
#inc asm
#inc hdd
#inc float
int int0();
int fab(int a, int addr_counter)
{
    *(addr_counter)++;
    if(a<=2) return 1;
    return fab(a-1,addr_counter)+fab(a-2,addr_counter);
}

int test_fab() uses(int a)
{
    printi(fab(1,&a),0);
    println();
    printi(fab(2,&a),0);
    println();
    a=0;
    printi(fab(30,&a),0);
    println();
    printi(a,0);
    printstr(" function calls\r\n");
}

int int0()
{
}
int main() uses(int fa, int fb, int fc)
{
    //foo1();
    on_interrupt(0, int0);
    enable_interrupt();
    /*ff(&fa,1,100);
    ff(&fb,2,50);
    asm("int 3");
    fadd(&fa,&fa,&fb); //fa+=fb
    ff(&fb,100,1);
    fmul(&fa,&fa,&fb);
    asm("int 3");
    printi(ftoi(&fa),0);
    println();*/
    /*for(i=0;i<1000;++i)
    {
        for(j=0;j<1000;++j)
        {
            if(j%3==0) continue;
            printnum(j);
        }
    }
    i=0;
    println();
    while(i<1000)
    {
        for(j=0;j<1000;++j)
        {
            if(j%3==0) continue;
            printnum(j);
        }
        ++i;
    }
    println();
    */
    writebyte(1,"W");
    test_fab();
    printi(rdtsc(),0);
    printstr(" instructions\r\n");
    asm("int 3");
}