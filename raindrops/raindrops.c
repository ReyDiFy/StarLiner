#include <stdlib.h>

int main(){
<<<<<<< HEAD
  int YCoord[720];
  for (int y = 0; y <= 720; y++){
    if (YCoord[y] == NULL){
      YCoord[y] = 1;
    }
       printf("%d",YCoord[y]);
=======
  int ScreenLength[60];
  for (int x = 0; x != 60; x++){
    ScreenLength[x] = ScreenLength[x] + 1;
  }
  for (int y = 0; y != 60; y++){
    printf("%d", ScreenLength[y]);
>>>>>>> 07d4bc70544d1eed654a5e38abf1d7a90339710d
  }
}
