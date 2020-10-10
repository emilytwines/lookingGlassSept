mergeInto(LibraryManager.library, {

  openWindowT: function () {

     document.onmouseup = function() {
          var url = "http://www.playlookingglass.com/join";
          
          window.open(url, '_blank');
        
         document.onmouseup = null;
      }
  },

});