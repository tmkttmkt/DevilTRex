import cv2
import numpy as np

def replace_pattern(input_image_path, output_image_path, target_pattern_path, replacement_pattern_path):
    # 画像を読み込む
    input_image = cv2.imread(input_image_path)
    target_pattern = cv2.imread(target_pattern_path)

    # ターゲットパターンのマッチング
    result = cv2.matchTemplate(input_image, target_pattern, cv2.TM_CCOEFF_NORMED)
    min_val, max_val, min_loc, max_loc = cv2.minMaxLoc(result)
    if not os.path.exists(output_folder):
        os.makedirs(output_folder)

    # マッチングが見つかった場合
    if max_val > 0.8:  # 閾値は適宜調整
        h, w = target_pattern.shape[:2]

        # 置き換えパターンを読み込む
        replacement_pattern = cv2.imread(replacement_pattern_path)

        # 画像の該当部分を置き換え
        input_image[max_loc[1]:max_loc[1] + h, max_loc[0]:max_loc[0] + w] = replacement_pattern

        # 結果を保存
        cv2.imwrite(output_image_path, input_image)
        print("画像を置き換えました。")
    else:
        print("ターゲットパターンが見つかりませんでした。")

if __name__ == "__main__":
    replace_pattern("moto/torannpu-illust2.png","saki/output.png", "sped.png","saki.png" )
