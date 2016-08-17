$(document).ready(function(){
  $('#topBar td').mouseover(function(){
    $(this).addClass('menuHighlight')
  })
  .mouseout(function(){
    $(this).removeClass('menuHighlight')
  })
  $('#products tr').mouseover(function(){
    $(this).addClass('productsHighlight')
  })
  .mouseout(function(){
    $(this).removeClass('productsHighlight')
  })
})
