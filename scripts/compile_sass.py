#!/usr/bin/env python3
import subprocess
import os

def compile_sass(input_file, output_file):
    try:
        subprocess.run(['sass', input_file, output_file], check=True)
        print(f'Successfully compiled {input_file} to {output_file}')
    except subprocess.CalledProcessError as e:
        print(f'Failed to compile {input_file} to {output_file}: {str(e)}')

if __name__ == '__main__':
    path_to_sass = os.path.abspath('./wwwroot/sass/site.scss')
    path_to_css = os.path.abspath('./wwwroot/css/site.css')
    compile_sass(path_to_sass, path_to_css)