int itof(int a_addr, int data);
int ff(int a_addr, int data1, int data2) uses(int tmp_addr);
int ftoi(int a_addr);
int fadd(int c_addr, int a_addr, int b_addr);
int fsub(int c_addr, int a_addr, int b_addr);
int fmul(int c_addr, int a_addr, int b_addr);
int fdiv(int c_addr, int a_addr, int b_addr);
int printf(int a_addr);

#inc io
#incfile float.c