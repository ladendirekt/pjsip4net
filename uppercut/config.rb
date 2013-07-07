#require 'yaml'
require 'thor'
require 'FileUtils'

module Uppercutbuild
	#class Config < Thor::Group
		#include Thor::Actions
		
		#@config_file = ".nu/options.yaml"
		
		#def self.get_config
		#	unless File.exists? @config_file
		#		FileUtils.touch @config_file
		#		append_file @config_file, YAML::dump({})	
		#	end
		#	cd = YAML.load_file @config_file
		#	cd = ask_about_libdir cd
		#	
		#	save_file cd
		#	cd
		#end
		
		#def self.ask_about_libdir(config)
		#	if config['lib'].nil?
		#		loc = ask "Where do you want me to copy things to?"
		#		config = {'lib'=>loc}
		#	end
		#	config
		#end
		
		#def self.save_file(config)
		#	File.open(@config_file, 'w') do |out|
		#		YAML.dump( config, out)
		#	end
		#end
	#end
end