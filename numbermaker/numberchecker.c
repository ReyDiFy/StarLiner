#include <stdio.h>
int enterVariable(){
  int Var;
  scanf("%d", &Var);
  return Var;
}
int main(){
  printf("Input a number: ");
  int i = enterVariable();
  if(i < 100){
    printf("%d is between 1 and 100\n", i);
  }
  else if(i < 200 && i > 99){
    printf("%d is between 101 and 200\n", i);
  }
  else if(i < 300 && i > 199){
    printf("%d is between 201 and 300\n", i);
  }
  else if(i < 400 && i > 299){
    printf("%d is between 301 and 400\n", i);
  }
  else if(i < 501 && i > 399){
    printf("%d is between 401 and 500\n", i);
  }
}

