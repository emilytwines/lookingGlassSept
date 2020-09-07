mergeInto(LibraryManager.library, {

  openWindowT: function () {

     document.onmouseup = function() {
          var url = "https://us02web.zoom.us/j/7283544436";
          
          window.open(url, '_blank');
        
         document.onmouseup = null;
      }
  },

});