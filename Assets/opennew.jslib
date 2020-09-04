mergeInto(LibraryManager.library, {

  openWindow: function () {
      console.log("openWindow");
      document.onkeyup = function() {
          //var url = "https://repl.it/@emilytwines/Look?lite=true&outputonly=true";
          var url = "http://look2.emilytwines.repl.run/";
          window.open(url, '_blank');
          console.log("onkeyup");
          document.onkeyup = null;
      }
  },

});