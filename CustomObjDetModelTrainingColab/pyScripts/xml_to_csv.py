import os
import glob
import pandas as pd
import xml.etree.ElementTree as ET


def xml_to_csv(path):
  counter = 0
  xml_list = []
  for xml_file in glob.glob(path + '/*.xml'):
    try:
      tree = ET.parse(xml_file)
      counter += 1
    except:
      print('Error', xml_file)
      continue
    root = tree.getroot()
    for member in root.findall('object'):
      value = (root.find('filename').text,
              int(root.find('size')[0].text),
              int(root.find('size')[1].text),
              member[0].text,
              int(member[4][0].text),
              int(member[4][1].text),
              int(member[4][2].text),
              int(member[4][3].text)
              )
      xml_list.append(value)
  column_name = ['filename', 'width', 'height', 'class', 'xmin', 'ymin', 'xmax', 'ymax']
  xml_df = pd.DataFrame(xml_list, columns=column_name)
  print(path, 'processed', counter, 'files')
  return xml_df


def main():
  for folder in ['train','test']:
    image_path = os.path.join(os.getcwd(), ('images/' + folder))
    xml_df = xml_to_csv(image_path)
    xml_df.to_csv(('images/' + folder + '_labels.csv'), index=None)
    print('Successfully converted xml to csv.')


main()
