section .data

msg: DB 'Hello World!', 10
  msgsize EQU $ - msg


global start
  section .text

start: 
  mov rax, 4
  mov rbx, 1
  mov rcx, msg
  mov rdx, msgsize
  int 0x80
