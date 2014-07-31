int halt()
{
    asm("cli");
    asm("hlt");
}

int rdtsc()
{
    asm("rdtsc");
    asm("popi eax");
}

int debug()
{
    asm("int 3");
}