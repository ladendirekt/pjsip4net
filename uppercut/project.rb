module Uppercutbuild
  class Project
  
    def initialize
     # @config_file = ".uc/options.yaml"
    end

    # def ensure_default_config
      # if File.exist? @config_file
  			# return
  		# end
  		# add_file @config_file
  		# content = YAML::dump( {'lib'=>'lib'} )
  		# append_file @config_file, content 
    # end
  
    def get_location
  		# content = YAML.load_file @config_file
  		# content['lib']
      ""
    end
	
    #def set_location(name)
  	  # File.delete @config_file if File.exist? @config_file

  		# content = YAML::dump( { 'lib' => name })
		
  		# File.open(@config_file, 'w') {|f| f.write(content) }
    # end
  end
end