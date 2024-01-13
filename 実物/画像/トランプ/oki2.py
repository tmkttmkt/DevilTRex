import cv2
import os
import numpy as np

def replace_pattern_in_folder(input_folder, output_folder, target_pattern_path, replacement_pattern_path):

    # ターゲットパターンを読み込む
    target_pattern = cv2.imread(target_pattern_path)

    # 入力フォルダ内のすべての画像に対して処理
    for filename in os.listdir(input_folder):
        if filename.endswith(".jpg") or filename.endswith(".png"):  # 画像ファイルの拡張子を指定
            input_image_path = os.path.join(input_folder, filename)
            output_image_path = os.path.join(output_folder, filename)

            # 画像を読み込む
            input_image = cv2.imread(input_image_path)

            # ターゲットパターンのマッチング
            result = cv2.matchTemplate(input_image, target_pattern, cv2.TM_CCOEFF_NORMED)
            min_val, max_val, min_loc, max_loc = cv2.minMaxLoc(result)

            # マッチングが見つかった場合
            if max_val > 0.8:  # 閾値は適宜調整
                n=0
                while max_val > 0.9: 
                    h, w = target_pattern.shape[:2]

                    # 置き換えパターンを読み込む
                    replacement_pattern = cv2.imread(replacement_pattern_path)

                    # 画像の該当部分を置き換え
                    input_image[max_loc[1]:max_loc[1] + h, max_loc[0]:max_loc[0] + w] = replacement_pattern

                    result = cv2.matchTemplate(input_image, target_pattern, cv2.TM_CCOEFF_NORMED)
                    min_val, max_val, min_loc, max_loc = cv2.minMaxLoc(result)
                    print(max_val)
                    n+=1
                # 結果を保存
                cv2.imwrite(output_image_path, input_image)
                print(f"{filename} を{n}回置き換えました。")
            else:
                print(f"{filename} にターゲットパターンが見つかりませんでした。")

# 使用例
"""
replace_pattern_in_folder("moto", "saki", "hart1.png", "hart-1.png")
replace_pattern_in_folder("saki", "saki", "hart2.png", "hart-1.png")

replace_pattern_in_folder("saki", "saki", "hart3.png", "hart-2.png")
replace_pattern_in_folder("saki", "saki", "hart4.png", "hart-3.png")
"""

replace_pattern_in_folder("saki", "saki", "hart1.png", "hart-1.png")
