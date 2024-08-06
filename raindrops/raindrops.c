#include <stdlib.h>

int main(){
  int ScreenLength[60];
  for (int x = 0; x != 60; x++){
    ScreenLength[x] = ScreenLength[x] + 1;
  }
  for (int y = 0; y != 60; y++){
    printf("%d", ScreenLength[y]);
  }
}
