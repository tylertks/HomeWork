$(document).ready(function(){
  $('#topBar td').mouseover(function(){
    $(this).addClass('menuHighlight')
  },function(){
    $(this).removeClass('menuHighlight')
  })
})
