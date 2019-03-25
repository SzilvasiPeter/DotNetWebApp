// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

  
    // Scrolling navigation bar
    $(window).scroll(function() {
      if($(window).scrollTop() > 80){
        $('.myLogo').css({'height': '70px', 'width' : '70px'});
        $('.nav-link').css({'margin' : '8px'});
       }else{
        $('.myLogo').css({'height': '100px', 'width' : '100px'});
        $('.nav-link').css({'margin-left' : '40px', 'margin-right' : '40px'});
       }
     })

    // Faster carousel
    $('.carousel').carousel({
        interval: 2500,
        cycle: true
    })