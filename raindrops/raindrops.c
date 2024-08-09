#include <stdlib.h>

int main(){
  int YCoord[720];
  for (int y = 0; y <= 720; y++){
    if (YCoord[y] == NULL){
      YCoord[y] = 1;
    }
       printf("%d",YCoord[y]);
  }
}
