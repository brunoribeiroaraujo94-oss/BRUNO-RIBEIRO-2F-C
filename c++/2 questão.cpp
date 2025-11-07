#incluide <iostream>
using namespace std;
int main() {
    int i,vet[15], menor,maior;
    for(i=0;i<15;i++){
        cout<<"Digite um valor para a posicao "<<i<<": ";
        cin>>vet[i];
        if(i==0){
            menor=vet[i];
            maior=vet[i];
        }
        if(vet[i]<menor){
            menor=vet[i];
        }
        if(vet[i]>maior){
            maior=vet[i];
        }
        cout<<"maior numero e "<<maior<<endl;
        cout<<"menor numero e "<<menor<<endl;
    }
    return 0;   
}