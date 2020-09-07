mergeInto(LibraryManager.library, {

  openWindowF: function () {

     document.onmouseup = function() {
          var url = "http://www.playlookingglass.com/watch";
          
          window.open(url, '_blank');
        
         document.onmouseup = null;
      }
  },

});