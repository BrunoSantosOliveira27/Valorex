function filter(categoria){
    //alterar a visibilidade dos cards
    let cardCount = 0;
    document.querySelectorAll('.poke').forEach(card => {
        card.style.display = "flex";
        cardCount += 1;
        if(!card.classList.contains(categoria) && categoria !== ''){ 
            card.style.display = 'none';
            cardCount -= 1;
    }});

    // verificar se existem cards 
   let zeroPersonagem = document.querySelector('#zeroPersonagem');
   cardCount == 0 ? 
   zeroPersonagem.classList.remove('d-none'): 
   zeroPersonagem.classList.add('d-none');

   // alterar o estilo dos botoes de filtro
   document.querySelectorAll('.btn-filter').forEach(button =>{
    button.classList.add('btn-sm');
    button.classList.remove('btn-md');
        if(button.id == `btn-${categoria}`){
            button.classList.remove('btn-sm');
            button.classList.add('btn-md');
    } 
   });

}