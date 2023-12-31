# name, condition when to skip the test and extra dependencies
ugly_tests = [
  [ 'elements/x264enc', not x264_dep.found(), [ x264_dep, gmodule_dep ] ],
  [ 'generic/states' ],
]

# FIXME: unistd dependency or not tested yet on windows
if host_machine.system() != 'windows'
  ugly_tests += [
    [ 'elements/mpeg2dec', not mpeg2_dep.found() or not cdata.has('HAVE_UNISTD_H'), [ gstvideo_dep ] ],
  ]
endif

fsmod = import('fs')
test_defines = [
  '-UG_DISABLE_ASSERT',
  '-UG_DISABLE_CAST_CHECKS',
  '-DGST_CHECK_TEST_ENVIRONMENT_BEACON="GST_PLUGIN_LOADING_WHITELIST"',
  '-DGST_TEST_FILES_PATH="' + fsmod.as_posix(meson.current_source_dir()) + '/../files"',
  '-DGST_USE_UNSTABLE_API',
]

pluginsdirs = []
if gst_dep.type_name() == 'pkgconfig'
  pbase = dependency('gstreamer-plugins-base-' + api_version, required: true)
  pluginsdirs = [gst_dep.get_variable('pluginsdir'),
                 pbase.get_variable('pluginsdir')]
  gst_plugin_scanner_dir = gst_dep.get_variable('pluginscannerdir')
else
  gst_plugin_scanner_dir = subproject('gstreamer').get_variable('gst_scanner_dir')
endif
gst_plugin_scanner_path = join_paths(gst_plugin_scanner_dir, 'gst-plugin-scanner')

test_deps = [gst_dep, gstbase_dep, gstcheck_dep, gstaudio_dep, gstapp_dep,
             gstfft_dep, gstvideo_dep, gstpbutils_dep]

libm = cc.find_library('m', required : false)

# FIXME: valgrind_args: add suppressions $(top_srcdir)/common/gst.supp $(srcdir)/gst-plugins-ugly.supp

no_warn_args = []
foreach arg : [
  '-Wno-missing-prototypes',
  '-Wno-missing-declarations',
  '-Wno-old-style-definition']
  if cc.has_argument(arg)
    no_warn_args += [arg]
  endif
endforeach

foreach t : ugly_tests
  fname = '@0@.c'.format(t.get(0))
  test_name = t.get(0).underscorify()
  extra_deps = [ ]
  if t.length() == 3
    extra_deps = t.get(2)
    skip_test = t.get(1)
  elif t.length() == 2
    skip_test = t.get(1)
  else
    skip_test = false
  endif
  if not skip_test
    exe = executable(test_name, fname,
      include_directories : [configinc],
      c_args : ['-DHAVE_CONFIG_H=1' ] + test_defines + no_warn_args,
      dependencies : [libm] + test_deps + extra_deps,
    )

    env = environment()
    env.set('GST_PLUGIN_SYSTEM_PATH_1_0', '')
    env.set('CK_DEFAULT_TIMEOUT', '20')
    env.set('GST_PLUGIN_LOADING_WHITELIST', 'gstreamer', 'gst-plugins-base',
      'gst-plugins-good', 'gst-plugins-ugly@' + meson.project_build_root())
    env.set('GST_PLUGIN_PATH_1_0', [meson.global_build_root()] + pluginsdirs)
    env.set('GST_REGISTRY', join_paths(meson.current_build_dir(), '@0@.registry'.format(test_name)))
    env.set('GST_PLUGIN_SCANNER_1_0', gst_plugin_scanner_path)
    test(test_name, exe, env: env, timeout: 3 * 60)
  endif
endforeach
