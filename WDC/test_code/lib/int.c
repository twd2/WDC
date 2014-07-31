int enable_interrupt()
{
    asm("sei");
}

int disable_interrupt()
{
    asm("cli");
}
