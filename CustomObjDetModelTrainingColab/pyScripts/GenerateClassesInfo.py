"""
This script creates:
- generate_tfrecord.py
- labelmap.pbtxt

from 'classes.txt' file
"""
import os

if not os.path.isfile('classes.txt'):
    raise Exception('No file "classes.txt"')

# Read classes.txt
with open('classes.txt', 'r') as token:
    text = token.read()

# Read files - drop empty lines
classes = []
for line in text.split('\n'):
    if line:
        classes.append(line)
    pass  # line

# Show info
print('Got {} classes: {}'.format(len(classes), ', '.join(classes)))

# Generate files:
# 1. generate_tfrecord.py
KEY = '<INSERT_CLASSES_IFs_HERE>'  # Key that is being replaced
replacement = ''
for i in range(len(classes)):
    replacement += '    if row_label == \'' + classes[i] + '\':' + '\n        return ' + str(i + 1) + '\n'

# Read template
with open('Templates/generate_tfrecord_TEMPLATE.txt', 'r') as token:
    text = token.read()

# Insert classes info
text = text.replace(KEY, replacement)

# Save file
with open('generate_tfrecord.py', 'w') as token:
    token.write(text)


# 2. label_map.pbtxt
# Read template file
with open('Templates/labelmap_TEMPLATE.txt', 'r') as token:
    tmpl = token.read()

# Generate text
text = ''
for i in range(len(classes)):
    text += tmpl.replace('<INSERT_ID>', str(i+1)).replace('<INSERT_NAME>', classes[i]) + '\n'

# Save to file
with open('labelmap.pbtxt', 'w') as token:
    token.write(text)
    
with open('label_map.pbtxt', 'w') as token:
    token.write(text)
