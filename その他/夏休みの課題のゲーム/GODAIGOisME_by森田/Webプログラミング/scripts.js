function decreaseGifOpacity() {
      const gifBackground = document.getElementById("gifBackground");
      gifBackground.style.opacity = 0; // �����x��0�ɐݒ�
    }
    window.addEventListener("load", function() {
      setTimeout(decreaseGifOpacity, 5000); // 5�b��ɓ����x��������
    });
    let opacity = 0.1; 
    let fadeButton = document.getElementById('fade-button');
    const increaseOpacityButton = document.getElementById('increaseOpacityButton');
    const increaseOpacityButton2 = document.getElementById('increaseOpacityButton2');
    const increaseOpacityButton3 = document.getElementById('increaseOpacityButton3');
    const increaseOpacityButton4 = document.getElementById('increaseOpacityButton4');
    window.addEventListener("load", function() {
      // �y�[�W�ǂݍ��݌�A�e�L�X�g�̓����x�𑝉�������A�j���[�V�������J�n
      const fadeInText = document.getElementById("fadeInText");
      const subtitle = document.getElementById("subtitle");
      fadeTextIn(fadeInText, 0);
      fadeTextIn2(subtitle, 0);
    });
    let isFaded = false;
        square.style.opacity = 0;
	text.style.display = "none";
	text2.style.display = "none";
	increaseOpacityButton.style.opacity = 0;
	increaseOpacityButton2.style.opacity = 0;
	increaseOpacityButton3.style.opacity = 0;
	increaseOpacityButton4.style.opacity = 0;
    function toggleOpacity() {
      if (isFaded) {
        square.style.opacity = 0;
	text.style.display = "none";
	text2.style.display = "none";
	increaseOpacityButton.style.opacity = 0;
	increaseOpacityButton2.style.opacity = 0;
	increaseOpacityButton3.style.opacity = 0;
	increaseOpacityButton4.style.opacity = 0;
      } else {
	square.style.opacity = 0.5;
	text.style.display = "block";
	text2.style.display = "block";
	increaseOpacityButton.style.opacity = 1;
	increaseOpacityButton2.style.opacity = 1;
	increaseOpacityButton3.style.opacity = 1;
	increaseOpacityButton4.style.opacity = 1;
      }
      isFaded = !isFaded;
    }
function fadeTextIn(element, opacity) {
      const interval = setInterval(function() {
        opacity += 0.05; // �����x��0.05������������
        element.style.opacity = opacity;

        if (opacity >= 1) {
          clearInterval(interval); // �����x��1�ȏ�ɂȂ�����C���^�[�o�����N���A
        }
      }, 100); // �C���^�[�o���̊Ԋu (100�~���b���Ƃɓ����x��ύX)
    }
function fadeTextIn2(element, opacity) {
      const interval = setInterval(function() {
        opacity += 0.025; // �����x��0.05������������
        element.style.opacity = opacity;

        if (opacity >= 1) {
          clearInterval(interval); // �����x��1�ȏ�ɂȂ�����C���^�[�o�����N���A
        }
      }, 150); // �C���^�[�o���̊Ԋu (100�~���b���Ƃɓ����x��ύX)
    }

