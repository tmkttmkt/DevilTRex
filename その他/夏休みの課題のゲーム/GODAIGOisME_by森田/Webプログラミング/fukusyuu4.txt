<!DOCTYPE html>
<html>
<head>
  <style>
    .rectangle {
      width: 100px;
      height: 100px;
      background-color: red;
      position: absolute;
    }
  </style>
</head>
<body>
  <div class="rectangle"></div>

  <script>
    const rectangle = document.querySelector('.rectangle');
    let isResizing = false;
    let startX, startY, startWidth, startHeight;

    rectangle.addEventListener('mousedown', (e) => {
      isResizing = true;
      startX = e.clientX;
      startY = e.clientY;
      startWidth = parseInt(document.defaultView.getComputedStyle(rectangle).width, 10);
      startHeight = parseInt(document.defaultView.getComputedStyle(rectangle).height, 10);

      document.addEventListener('mousemove', resize);
      document.addEventListener('mouseup', stopResize);
    });

    function resize(e) {
      if (!isResizing) return;

      const newWidth = startWidth + (e.clientX - startX);
      const newHeight = startHeight + (e.clientY - startY);

      rectangle.style.width = newWidth + 'px';
      rectangle.style.height = newHeight + 'px';
    }

    function stopResize() {
      isResizing = false;
      document.removeEventListener('mousemove', resize);
      document.removeEventListener('mouseup', stopResize);
    }
  </script>
</body>
</html>