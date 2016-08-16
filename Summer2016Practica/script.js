$(document).ready(function(){
  $('#topBar td').mouseover(function(){
    $(this).addClass('menuHighlight')
  })
  .mouseout(function(){
    $(this).removeClass('menuHighlight')
  })
})
