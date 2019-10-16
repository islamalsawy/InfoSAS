$(document).ready(function() {
  $("#Read").click(function() {
    var elem = $("#Read").text();
    if (elem == "Read More") {
      //Stuff to do when btn is in the read more state
      $("#Read").text("Read Less");
      $("#text").slideDown();
    } else {
      //Stuff to do when btn is in the read less state
      $("#Read").text("Read More");
      $("#text").slideUp();
    }
  });
});