grammar myl;
prog       : (stat)*;
stat       : (SEM
           | let_stat SEM
           | if_stat
           | while_stat
           | for_stat
           | self_addsub_stat SEM
           | on_interrupt_stat SEM
           //| enable_interrupt_stat SEM
           //| disable_interrupt_stat SEM
           //| putchar_stat SEM
           | break_stat SEM
           | continue_stat SEM
           | asm SEM
           | func_call SEM
           | func_dec SEM
           | func_def
           | func_ret SEM
           )
           | '{' (stat)* '}' //stat_block
           ;


break_stat: 'break'
          ;

continue_stat: 'continue'
             ;

on_interrupt_stat: 'on_interrupt' '(' number_expr ',' ID ')'
            ;
/*
enable_interrupt_stat: 'enable_interrupt' '(' ')'
            ;

disable_interrupt_stat: 'disable_interrupt' '(' ')'
            ;
*/
/*
putchar_stat: 'putchar' '(' number_expr ')'
            ;
*/
let_stat: var_ref LET number_expr
        ;

while_stat: 'while' '(' number_expr ')' stat
       ;

for_stat: 'for' '(' sinit=stat number_expr SEM sstep=for_step ')' smain=stat
       ;

for_step: let_stat|self_addsub_stat|stat
        ;

if_stat: 'if' '(' number_expr ')' stat #if_node
       | 'if' '(' number_expr ')' truestat=stat 'else' falsestat=stat #ifelse_node
       ;

func_dec: TYPE ID '(' params_def=ids_def ')' #func_dec_no_var
        | TYPE ID '(' params_def=ids_def ')' 'uses' '(' vars_def=ids_def ')' #func_dec_var
        ;

func_def: TYPE ID '(' params_def=ids_def ')' stat #func_def_no_var
        | TYPE ID '(' params_def=ids_def ')' 'uses' '(' vars_def=ids_def ')' stat #func_def_var
        ;

ids_def: (TYPE ID (',' TYPE ID)*)?
          ;

func_ret: 'return' number_expr
        ;

asm: 'asm' '(' STRING ')'
   ;

//  ! ++ -- * / << >> + -  % != == >= < <= && ^ ||
number_expr: NOT number_expr #not_node 
           | number_expr op=(MUL|DIV) number_expr #muldiv
           | number_expr op=(SHL|SHR) number_expr #shlshr
           | number_expr op=(ADD|SUB) number_expr #addsub
           | number_expr MOD number_expr #mod_node
           | number_expr op=(NEQU|EQU|GT|GTE|LT|LTE) number_expr #num_cmp_node
           | number_expr AND number_expr #and_node 
           | number_expr XOR number_expr #xor_node 
           | number_expr OR number_expr #or_node 
           | func_call #func_node
           //| 'getchar' '(' ')' #getchar_node
           | self_addsub #self_addsub_node
           | var_ref #ref_node
           | '&' var_ref #ref_addr_node
           | CHAR #char_node
           | INT #int_node
           | CONST #const_node
           | '(' number_expr ')' #number_expr_node
           ;

self_addsub_stat: self_addsub
                ;

self_addsub: var_ref '++' #varadd_node
           | '++' var_ref #addvar_node
           | var_ref '--' #varsub_node
           | '--' var_ref #subvar_node
           ;

var_ref: '*' '(' number_expr ')' #addrref_node
       | ID '[' number_expr ']' #idref_node
       | ID #id_node
       | '(' var_ref ')' #var_ref_node
       ;

func_call: ID '(' params_use ')' #params_node
         | ID '(' STRING ')' #string_node
         ;

params_use: (number_expr (',' number_expr)*)?
      ;

/*
string_expr: string_expr MUL number_expr #strmul
           | string_expr ADD string_expr #strcat
           | ('toStr'|'toString'|'S') '(' number_expr ')'  #str_num_node
           | ID #str_id_node
           | CHAR #char_node
           | STRING #str_node
           ;


id_def: TYPE ID (',' ID)*
      ;

*/

TYPE       : ('int'|'double')
           ;

ID         : [a-zA-Z_] [0-9a-zA-Z_]* ; 
//KEYWORD    : DESC | TYPE | TRUE | FALSE | UNKNOWN | AND | OR | XOR | NOT;

INT        : [0-9]+;

//STATENDING : (COMM_BLOCK | LINE_COMM | NEWLINE | SEM) ;

COMM_BLOCK : '/*' .*? '*/' -> skip ;

LINE_COMM  : '//' .*? NEWLINE -> skip ;

NEWLINE    : ('\r' ? '\n')+  -> skip ; 

CHAR     : '"' ('\\'["ntr\\]|.)  '"';

STRING     : '"' ('\\'["ntr\\]|.)*?  '"';

CONST      : TRUE | FALSE;

TRUE       : 'true';
FALSE      : 'false';
//INF        : 'inf';
LET        : '=';
EQU        : '==';
GT         : '>';
SHR        : '>>';
GTE        : '>=' | '=>';
LT         : '<';
SHL        : '<<';
LTE        : '<=' | '=<';
MOD        : '%';
ADD        : '+';
SUB        : '-';
MUL        : '*';
DIV        : '/';
AND        : '&&' | '&';
OR         : '||' | '|';
NOT        : '!' | '~';
NEQU       : '!=' | '~=';
XOR        : '^^' | '^';
SEM        : ';';

WS         : [ \t\r\n]+ -> skip ; // skip spaces, tabs, newlines